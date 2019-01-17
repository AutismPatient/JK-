(function ($) {
    var _service = abp.services.app.feedBack;
    var _model = $("#editModel");
    var form = _model.find('form[name=ThisForm]');
    form.closest("div .modal-content").find('.save-button').click(function (e) {
        e.preventDefault();
        save();
    });
    form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            save();
        }
    });
    function save() {
        if (!form.valid) {
            return;
        }
        var formpl = form.serializeFormToObject();
        abp.ui.setBusy(_model);
        _service.sendToUsers(formpl).done(function () {
            _model.modal('hide');
            abp.notify.success("您已成功回复客户！");
            setInterval(function () { location.reload(true); }, 1500);
        }).always(function () {
            abp.ui.clearBusy(_model);
        });
    }
})(jQuery);