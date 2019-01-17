
(function ($) {
        var _categoryService = abp.services.app.newsCategory;
        var _model = $("#CategoryEditModal");
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

            var category = form.serializeFormToObject();
            abp.ui.setBusy(_model);
            _categoryService.update(category).done(function () {
                _model.modal('hide');
                abp.notify.success("修改数据成功！");
                setInterval(function () { location.reload(true); },1500);
            }).always(function () {
                abp.ui.clearBusy(_model);
            });
        }
})(jQuery);