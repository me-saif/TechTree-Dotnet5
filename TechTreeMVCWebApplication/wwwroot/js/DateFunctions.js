function AddSubstractMonths(date, numMonths) {
    var month = date.getMonth();
    var milliseconds = new Date(date).setMonth(month + numMonths);
    return new Date(milliseconds);
}