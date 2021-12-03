$(function () {

    function WireUpDatePicker() {

        const addMonths = 2;
        var currDate = new Date();

        $('.datepicker').datepicker(
            {
                dateFormat: 'yy-mm-dd',
                minDate: new Date(),
                maxDate: AddSubstractMonths(currDate, addMonths)
            }
        );
    }
    WireUpDatePicker();
});