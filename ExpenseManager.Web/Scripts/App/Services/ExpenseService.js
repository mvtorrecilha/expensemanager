var app = angular.module("expensemanagerApp");
app.service("ExpenseService", function ($http, $q) {

    this.GetById = function (id) {
        $http.get('/Expense/GetbyId?id=' + id, { data: {} }).then(
          function (result) {
              deferred.resolve(result.data);
          });
        var deferred = $q.defer();

        return deferred.promise;
    };

    this.GetAll = function () {
        $http.get('/Expense/GetAll', { data: {} }).then(
          function (result) {
              deferred.resolve(result.data);
          });
        var deferred = $q.defer();

        return deferred.promise;
    };

    this.Save= function(Expense) {
        return $http.post('/Expense/Save', Expense)
            .then(
            function (response) {
                return response.data;
            },
            function (errResponse) {
                return $q.reject(errResponse);
            }
        );
    };

});