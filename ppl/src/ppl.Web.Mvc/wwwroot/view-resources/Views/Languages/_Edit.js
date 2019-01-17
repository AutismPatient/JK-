(function ($) {
    var _service = abp.services.app.languages;
    var _modal = $("#LanguagesEditModal");
    var _form = _modal.find("form[name=languagesEditForm]");
    _form.validate();
    function refreshList() {
        location.reload(true);
    }
    _form.closest("div .modal-content").find('.save-button').click(function (e) {
        e.preventDefault();
        if (!_form.valid())
            return;
        var check = $("input[name=IsDisabled]");
        if (check.is(":checked"))
            check.prop("value", "true");
        else
            check.prop("value", "false");
        abp.ui.setBusy(_modal);
        var data = _form.serializeFormToObject();
        data.Icon = data.DisplayName;
        _service.updateLanguage({ Language:data}).done(function () {
            abp.notify.success("修正数据成功！");
            _modal.modal('hide');
            setTimeout(function () { refreshList(); }, 1000);
        }).always(function () {
            abp.ui.clearBusy(_modal);
        });
    });
})(jQuery);