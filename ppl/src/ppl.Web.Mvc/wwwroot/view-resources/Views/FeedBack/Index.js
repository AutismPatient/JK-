(function () {
    $(function () {
        var _service = abp.services.app.feedBack;
        $("input[name=seacrh]").keypress(function (e) {
            if (e.keyCode === 13) {
                window.location.href = "../../FeedBack/Index?SearchedName=" + $(this).val();
            }
        });
        $('input[id=TotalPageCount]').change(function () {
            if ($(this).val() <= 0) {
                $(this).val(1);
                return;
            }
            $("#jump").prop("href", "../../FeedBack/Index?PageIndex=" + $(this).val());
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
                        _service.batchDelete(name).done(function () {
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
                        _categoryService.batchRecover(name).done(function () {
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
            var Id = $(this).attr('data-id');
            abp.message.confirm(
                abp.utils.formatString("你确定要删除数据吗？"),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _service.delete(Id).done(function () {
                            abp.notify.success("操作成功！");
                            setTimeout(function () { refreshList(); }, 1000);
                        });
                    }
                }
            );
        });
        $(".reply").click(function (e) {
            var Id = $(this).attr('data-id');
            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'FeedBack/GetEdit?Id=' + Id,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#editModel div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });
    });
})();