var app = angular.module("expensemanagerApp");
app.controller("IndexCtrl", function ($scope, $http, $location, ExpenseService) {
    $scope.message = '';
    $scope.result = "color-default";
    $scope.isViewLoading = false;

    ExpenseService.GetAll().then(function (Expenses) {
        //$scope.Expenses = Expenses;
        $scope.Expenses = Expenses;
    });

    $scope.orderBy = function (field) {
        $scope.sortCriteria = field;
    }

    $scope.Create = function () {
        $location.path("Expense/Create");
    }

    $scope.Edit = function (id) {
        $location.path("Expense/Update/" + id);
    }

    $scope.Delete = function (id) {
        $location.path("Expense/Delete/" + id);
    }

});