(function () {
    $(function () {
        var _service = abp.services.app.languages;
        
        var _modal = $("#LanguagesCreateModal");
        var form =_modal.find("form[name=languagesCreateForm]");

        $('#RefreshButton').click(function () {
            refreshList();
        });
        function refreshList() {
            location.reload(true);
        }

        function IsCheck() {
            var check = $("input[name=IsEnabled]");
            if (check.is(":checked"))
                check.prop("value", "true");
            else
                check.prop("value", "false");
        }
        form.validate({
            
        });
        $(".delete").click(function (e) {
            e.preventDefault();
            var id = $(this).attr("data-id");
            var name = $(this).attr("data-name");
            DeleteFunction(id, name);
        });
        _modal.find("#submit").click(function (e) {
            e.preventDefault();
            if (!form.valid()) {
                return;
            }
            IsCheck();
            var data = form.serializeFormToObject();
            data.Icon = data.DisplayName;
            abp.ui.setBusy(_modal);
            _service.createLanguage({ Language:data}).done(function () {
                abp.notify.success("添加数据成功！");
                _modal.modal('hide');
                setTimeout(function () { refreshList(); }, 1000);
            }).always(function () {
                abp.ui.clearBusy(_modal);
            });
        });

        function DeleteFunction(id,name) {
            abp.message.confirm(
                abp.utils.formatString("你确定要删除语言：  " + name + "  吗？"),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _service.deleteLanguage({id:id}).done(function () {
                            abp.notify.success("删除成功！");
                            setTimeout(function () { refreshList(); }, 1000);
                        });
                    }
                }
            );
        }

        $(".edit").click(function (e) {
            e.preventDefault();
            var Id = $(this).attr("data-id");
            $.ajax({
                url: abp.appPath + 'Languages/GetLanguagesEdit?Id=' + Id,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#LanguagesEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });
    });
})();