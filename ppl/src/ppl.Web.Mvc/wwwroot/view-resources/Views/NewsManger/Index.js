(function () {
    $(function () {
        var _newsService = abp.services.app.newsManger;
        var _model = $("#NewsCreateModal");
        var form = _model.find('form[name=NewsCreateForm]');
        form.validate({

        });
        $("input[name=seacrh]").keypress(function (e) {
            if (e.keyCode === 13) {
                window.location.href = abp.appPath +"News/NewsIndex?SearchedName=" + $(this).val();
            }
        });
        var pageindex = $("#PageIndex").text();
        var pagecount = $("#PageCount").text();
        $('input[id=TotalPageCount]').change(function () {
            if ($(this).val() <= 0) {
                $(this).val(1);
                return;
            }
            $("#jump").prop("href", abp.appPath+"NewsManger/NewsIndex?PageIndex=" + $(this).val());
        });
        //标签选择
        $("#NewsCreateModal .select-tag").on('click', '.tags', function () {
            $(this).remove();
            $("#NewsCreateModal .addselect-tag").append($(this).prop("outerHTML"));
            $("#NewsCreateModal .addselect-tag span i").text("clear");
        });
        $("#NewsCreateModal .addselect-tag").on('click', '.tags', function () {
            $(this).remove();
            $("#NewsCreateModal .select-tag").append($(this).prop("outerHTML"));
            $("#NewsCreateModal .select-tag span i").text("add");
        });
        
        $('#RefreshButton').click(function () {
            refreshList();
        });
        var str = "";
        var check = $('tbody input[type=checkbox]');
        var label = $('label[for=IsCheckAll]');
        $("#IsCheckAll").click(function () {
            if ($(this).is(":checked")) {
                check.prop("checked", true);
                label.text("取消");
            }
            else {
                check.prop("checked", false);
                label.text("全选");
            }
        });
        $("#DeleteList").click(function () {
            check.each(function () {
                if ($(this).is(":checked")) {
                    str += $(this).attr("data-id") + ",";
                }
            });
            str = str.substring(0, str.length - 1);
            if (str === "") {
                abp.notify.warn("未选择任何数据！请重试。");
                return;
            }
            BatchDelete(str);
        });
        
        function BatchDelete(name) {
            abp.message.confirm(
                abp.utils.formatString("你确定要删除所选的数据吗？"),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _newsService.batchDelete(name).done(function () {
                            abp.notify.success("批量删除成功！");
                            setTimeout(function () { refreshList(); }, 1000);
                        });
                    }
                }
            );
        }
        $("#replyList").click(function () {
            check.each(function () {
                if ($(this).is(":checked")) {
                    str += $(this).attr("data-id") + ",";
                }
            });
            str = str.substring(0, str.length - 1);
            if (str === "") {
                abp.notify.warn("未选择任何数据！请重试。");
                return;
            }
            BatchRecover(str);
        });
        function BatchRecover(name) {
            abp.message.confirm(
                abp.utils.formatString("你确定要恢复所选的数据吗？"),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _newsService.batchRecover(name).done(function () {
                            abp.notify.success("批量恢复成功！");
                            setTimeout(function () { refreshList(); }, 1000);
                        });
                    }
                }
            );
        }

        function refreshList() {
            location.reload(true);
        }
        $(".delete").click(function (e) {
            var newsId = $(this).attr('data-id');
            var newsName = $(this).attr('data-name');
            var deleteif = $(this).attr('data-delete');
            deleteSingle(newsId, newsName, deleteif);
        });
        $(".edit").click(function (e) {
            var Id = $(this).attr('data-id');
            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'News/EditModel?Id=' + Id,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#NewsEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });
        var re = "";
        if (!$("#NewsCreateModal input[name=Recommend]").is(":checked")) {
            re = "No";
        }
        $("#NewsCreateModal input[name=Recommend]").change(function () {
            if ($(this).is(":checked")) {
                re = "Yes";
                
            }
            else {
                re = "No";
            }
        });
        form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!form.valid()) {
                return;
            }
            $("#NewsCreateModal input[name=Content]").val($(".w-e-text").html());
            var tag = "";
            $("#NewsCreateModal .addselect-tag span").each(function () {
                if ($(this).html() === "") {
                    abp.notify.warn("至少选中一个标签！");
                    return;
                }
                else {
                    tag += $(this).attr("data-name") + ",";
                }
            });
            if (tag === "") {
                abp.notify.warn("至少选中一个标签！");
                return;
            }
            tag = tag.substring(0, tag.length - 1);
            //上传封面图片
            var img = "";
            var file = $("#NewsCreateModal input[name=CoverUrl]").get(0);
            var files = file.files;
            var datafor = new FormData();
            for (var i = 0; i < files.length; i++) {
                datafor.append(files[i].name, files[i]);
            }
            $.ajax({
                url: abp.appPath + 'News/Uploading',
                type: 'POST',
                async:false,
                contentType: false,
                processData: false,
                dataType:'json',
                data:datafor,
                success: function (result) {
                    if (result.result === "选择的图片已存在，请勿上传！") {
                        abp.notify.warn(result.result);
                        return;
                    }
                    else {
                        img = result.result;
                        
                    }
                },
                error: function (e) {
                    alert("There was error uploading files!");
                    return;
                }
            });
            if (img !== "" || img === undefined) {
                var news = form.serializeFormToObject();
                news.Recommend = re;
                abp.ui.setBusy(_model);
                _newsService.createSingle(news, tag, img).done(function () {
                    abp.notify.success("添加数据成功！");
                    _model.modal('hide');
                    setTimeout(function () { refreshList(); }, 1000);
                }).always(function () {
                    abp.ui.clearBusy(_model);
                });
            }
            else {
                return;
            }
        });
        //删除
        function deleteSingle(id, name, deleteif) {
            if (deleteif === "True") {
                abp.message.confirm(
                    abp.utils.formatString("你确定要恢复" + name + "吗？"),
                    function (isConfirmed) {
                        if (isConfirmed) {
                            _newsService.recover(id).done(function () {
                                abp.notify.success("数据恢复成功！");
                                setTimeout(function () { refreshList(); }, 1000);
                            });
                        }
                    }
                );
            }
            else {
                abp.message.confirm(
                    abp.utils.formatString("你确定要删除" + name + "吗？"),
                    function (isConfirmed) {
                        if (isConfirmed) {
                            _newsService.deleteSingle(id).done(function () {
                                abp.notify.success("删除成功！");
                                setTimeout(function () { refreshList(); }, 1500);
                            });
                        }
                    }
                );
            }
        }
        var auditid;
        $(".audit").click(function () {
            auditid= $(this).attr("data-id");
        });
        var modal1 = $("#NewsAuditModal");
        var form1 = $("form[id=AuditForm]");
        $("#auditsubmit").click(function () {
            if (auditid !== null || auditid !== undefined) {
                var select = $("#audit").val();
                abp.ui.setBusy(modal1);
                _newsService.audital(auditid,select).done(function () {
                    abp.notify.info("审核成功！");
                    modal1.modal('hide');
                    setTimeout(function () { refreshList(); }, 1000);
                }).always(function () {
                    abp.ui.clearBusy(modal1);
                });
            }
        });
    });
})();