var app = angular.module("expensemanagerApp");
app.filter("asDate", function () {
    return function (input) {
        return new Date(parseInt(input.substr(6)));
    }
});