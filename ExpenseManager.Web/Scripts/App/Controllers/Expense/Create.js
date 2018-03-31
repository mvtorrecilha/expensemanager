var app = angular.module("expensemanagerApp");
app.controller("CreateCtrl", function ($scope, $http, $routeParams, $location, CategoryService, ExpenseService) {
    $scope.Expense = {};

    $scope.message = '';
    $scope.resultCss = '';
    $scope.SelectedValue;

    CategoryService.GetAll().then(function (categories) {
        $scope.Categories = categories;
    });

    $scope.Save = function () {

        if ($scope.SelectedValue != null)
            $scope.Expense.CategoryId = $scope.SelectedValue.Id;

        ExpenseService.Save($scope.Expense).then(function (response) {
            CleanFields();
            $scope.message = 'Expense successfully registered.';
            $scope.resultCss = 'alert alert-success';

        },
        function (response) {
            $scope.message = 'Fail to register the expense.';
            $scope.resultCss = 'alert alert-danger';
        });
    }

    function CleanFields() {
        $scope.Expense.Amount = '';
        $scope.Expense.Date = '';
        $scope.SelectedValue = '';
    }

    $scope.Back = function () {
        $location.path("Expense");
    }

});