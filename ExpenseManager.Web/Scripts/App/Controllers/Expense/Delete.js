var app = angular.module("expensemanagerApp");
app.controller("DeleteCtrl", function ($scope, $http, $location, $filter, $routeParams, ExpenseService, ) {
    $scope.Expense = {};
    $scope.message = '';

    ExpenseService.GetById($routeParams.id).then(function (ExpenseFound) {
        $scope.Id = ExpenseFound.Id;
        $scope.Amount = ExpenseFound.Amount;
        $scope.Date = $filter('asDate')(ExpenseFound.Date);
    });

    $scope.Delete = function () {
        $http({
            url: '/Expense/DeleteConfirmed?id=' + $scope.Id,
            method: "POST"
        })
            .then(function (response) {
                $location.path("Expense");
            },
            function (response) {
                $scope.message = 'Fail to delete the expense.';
                $scope.resultCss = 'alert alert-danger';
            });
    }
});