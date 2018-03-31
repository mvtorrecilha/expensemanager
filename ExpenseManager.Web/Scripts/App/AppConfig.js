'use strict';
var app = angular.module('expensemanagerApp', ['ngRoute']);
app.config([
    '$locationProvider', '$routeProvider',
    function ($locationProvider, $routeProvider) {
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        }).hashPrefix('!');

        $routeProvider
        .when('/Home', { // For Home Page
            templateUrl: '/Home/Page',
        })
        .when('/Expense', { // For All Expense List
            templateUrl: '/Expense/Index',
            controller: 'IndexCtrl'
        })
        .when('/Expense/Create', { // For Create Expense page
            templateUrl: '/Expense/Create',
            controller: 'CreateCtrl'
        })
        .when('/Expense/Update/:id', { // For Update Expense page
            templateUrl: '/Expense/Update',
            controller: 'UpdateCtrl'
        })
        .when('/Expense/Delete/:id', { // For Delete Expense page
            templateUrl: '/Expense/Delete',
            controller: 'DeleteCtrl'
        })
        .otherwise({   // This is when any route not matched => error
            redirectTo: '/Home'
        })
    }]);





