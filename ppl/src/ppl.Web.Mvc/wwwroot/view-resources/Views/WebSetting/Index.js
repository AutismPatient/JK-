(function ($) {
    var service = abp.services.app.webSetting;
    var form = $("form[name=SettingForm]");
    var value = $("input[name=IsEnabled]");
    $('[data-toggle="tooltip"]').tooltip();
    function refreshList() {
        location.reload(true);
    }
    $(".save-button").click(function (e) {
        e.preventDefault();
        if (value.is(":checked")) {
            value.prop("value", "true");
        }
        else {
            value.prop("value", "false");
        }
        if (!form.valid()) {
            return;
        }
        abp.ui.setBusy($(".card"));
        var json = form.serializeFormToObject();
        service.updateSingle(json).done(function () {
            abp.notify.success("站点设置修改成功！");
            setTimeout(function () { refreshList(); }, 1000);
        }).always(function () {
            abp.ui.clearBusy($(".card"));
        });
    });

})(jQuery);