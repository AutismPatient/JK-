

(function ($) {
    var _tagService = abp.services.app.newsTag;
    var _model = $("#TagEditModal");
    var form = _model.find('form[name=EditForm]');
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

        var tag = form.serializeFormToObject();
        abp.ui.setBusy(_model);
        _tagService.update(tag).done(function () {
            _model.modal('hide');
            abp.notify.success("修改数据成功！");
            setInterval(function () { location.reload(true); }, 1500);
        }).always(function () {
            abp.ui.clearBusy(_model);
        });
    }
})(jQuery);