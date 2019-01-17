
(function ($) {
    var _newMangerService = abp.services.app.newsManger;
    var _model = $("#NewsEditModal");
    var form = _model.find('form[name=NewsEditForm]');
    _model.find('.save-button').click(function (e) {
        e.preventDefault();
        save();
    });
    form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            save();
        }
    });
    $("#NewsEditModal .select-tag").on('click', '.tags', function () {
        $(this).remove();
        $("#NewsEditModal .addselect-tag").append($(this).prop("outerHTML"));
        $("#NewsEditModal .addselect-tag span i").text("clear");
    });
    $("#NewsEditModal .addselect-tag").on('click', '.tags', function () {
        $(this).remove();
        $("#NewsEditModal .select-tag").append($(this).prop("outerHTML"));
        $("#NewsEditModal .select-tag span i").text("add");
    });
    var re = "";
    if (!$("#NewsEditModal input[name=Recommend]").is(":checked")) {
        re = "No";
    }
    else {
        re = "Yes";
    }
    $("#NewsEditModal input[name=Recommend]").change(function () {
        if ($(this).is(":checked")) {
            re = "Yes";

        }
        else {
            re = "No";
        }
    });
    function save() {
        
        if (!form.valid) {
            return;
        }
        $("#NewsEditModal input[name=Content]").val($("#NewsEditModal .w-e-text").html());
        var taglist = "";
        $("#NewsEditModal .addselect-tag span").each(function () {
            if ($(this).html() === "") {
                abp.notify.warn("至少选中一个标签！");
                return;
            }
            else {
                taglist += $(this).attr("data-name") + ",";
            }
        });
        if (taglist === "") {
            abp.notify.warn("至少选中一个标签！");
            return;
        }
        taglist = taglist.substring(0, taglist.length - 1);
        //上传封面图片
        var imgurl = "";
        var file = $("#NewsEditModal input[name=CoverUrl]").get(0);
        var files = file.files;
        var datafor = new FormData();
        for (var i = 0; i < files.length; i++) {
            datafor.append(files[i].name, files[i]);
        }
        if (files.length <= 0) {
            imgurl = $("#url").attr("src");
        }
        else {
            $.ajax({
                url: abp.appPath + 'News/Uploading',
                type: 'POST',
                async: false,
                contentType: false,
                processData: false,
                dataType: 'json',
                data: datafor,
                success: function (result) {
                    if (result.result === "选择的图片已存在，请勿上传！") {
                        abp.notify.warn(result.result);
                        return;
                    }
                    else {
                        imgurl = result.result;
                    }
                },
                error: function (e) {
                    alert("There was error uploading files!");
                    return;
                }
            });
        }
        if (imgurl !== "" || imgurl === undefined) {
            
            var news = form.serializeFormToObject();
            news.Recommend = re;
            abp.ui.setBusy(_model);
            _newMangerService.updateSingle(news, taglist, imgurl).done(function () {
                _model.modal('hide');
                abp.notify.success("修改数据成功！");
                setInterval(function () { location.reload(true); }, 1500);
            }).always(function () {
                abp.ui.clearBusy(_model);
            });
        }
        else {
            return;
        }
    }
})(jQuery);