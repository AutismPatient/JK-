(function () {
    $(function () {
        var _tagService = abp.services.app.newsTag;
        var _model = $("#TagCreateModal");
        var form = _model.find('form[name=TagCreateForm]');
        form.validate({

        });
        $("input[name=seacrh]").keypress(function (e) {
            if (e.keyCode === 13) {
                window.location.href = "../../NewsTags/Index?SearchedName=" + $(this).val();
            }
        });
        var pageindex = $("#PageIndex").text();
        var pagecount = $("#PageCount").text();
        $('input[id=TotalPageCount]').change(function () {
            if ($(this).val() <= 0) {
                $(this).val(1);
                return;
            }
            $("#jump").prop("href", "../../NewsTags/Index?PageIndex=" + $(this).val());
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
                        _tagService.batchDelete(name).done(function () {
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
                        _tagService.batchRecover(name).done(function () {
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
            var tagId = $(this).attr('data-id');
            var tagName = $(this).attr('data-name');
            var deleteif = $(this).attr('data-delete');
            deletetag(tagId, tagName, deleteif);
        });
        $(".edit").click(function (e) {
            var Id = $(this).attr('data-id');
            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'NewsTags/GetTagsEdit?Id=' + Id,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#TagEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });
        form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!form.valid()) {
                return;
            }
            var tag = form.serializeFormToObject();
            abp.ui.setBusy(_model);
            _tagService.create(tag).done(function () {
                abp.notify.success("添加数据成功！");
                _model.modal('hide');
                setTimeout(function () { refreshList(); }, 1000);
            }).always(function () {
                abp.ui.clearBusy(_model);
            });
        });
        function deletetag(id, name, deleteif) {
            if (deleteif === "True") {
                abp.message.confirm(
                    abp.utils.formatString("你确定要恢复" + name + "吗？"),
                    function (isConfirmed) {
                        if (isConfirmed) {
                            _tagService.recover(id).done(function () {
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
                            _tagService.delete(id).done(function () {
                                abp.notify.success("删除成功！");
                                setTimeout(function () { refreshList(); }, 1500);
                            });
                        }
                    }
                );
            }
        }
    });
})();