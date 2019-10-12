(function ($) {
    $(function () {

        var _$form = $('#TaskCreationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.task.create(input)
                    .done(function () {
                        location.href = '/Tasks';
                    });
            });
    });
})(jQuery);


(function ($) {
    //serializeFormToObject plugin for jQuery
    $.fn.serializeFormToObject = function () {
        //serialize to array
        var data = $(this).serializeArray();

        //add also disabled items
        $(':disabled[name]', this)
            .each(function () {
                data.push({ name: this.name, value: $(this).val() });
            });

        //map to object
        var obj = {};
        data.map(function (x) { obj[x.name] = x.value; });

        return obj;
    };
})(jQuery);