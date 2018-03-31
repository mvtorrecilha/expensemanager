var app = angular.module("expensemanagerApp");
app.controller("UpdateCtrl", function ($scope, $http, $location, $routeParams, $filter, CategoryService, ExpenseService) {
    $scope.Expense = {};
    $scope.message = '';
    $scope.SelectedValue = '';

    CategoryService.GetAll().then(function (categories) {
        $scope.Categories = categories;
    });

    ExpenseService.GetById($routeParams.id).then(function (ExpenseFound) {
        $scope.Id = ExpenseFound.Id;
        $scope.Amount = ExpenseFound.Amount;
        $scope.Date = $filter('asDate')(ExpenseFound.Date);
        $scope.SelectedValue = ExpenseFound.CategoryId;
     });

    $scope.Save = function () {
        var Expense = {
            Id: $scope.Id,
            Amount: $scope.Amount,
            CategoryId: $scope.SelectedValue,
            Date: $scope.Date
        };

        ExpenseService.Save(Expense).then(function (response) {
            CleanFields();
            $scope.message = 'Expense successfully edited.';
            $scope.resultCss = 'alert alert-success';

        },
        function (response) {
            $scope.message = 'Fail to edit the expense.';
            $scope.resultCss = 'alert alert-danger';
        });
        
    }

    function CleanFields() {
        $scope.Expense.Price = '';
        $scope.Expense.ExpenseDate = '';
        $scope.SelectedValue = '';
    }

});