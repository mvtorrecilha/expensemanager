var app = angular.module("expensemanagerApp");
app.service("CategoryService", function ($http, $q) {

    this.GetById = function (id) {
        $http.get('/Category/GetbyId?id=' + id, { data: {} }).then(
          function (result) {
              deferred.resolve(result.data);
          });
        var deferred = $q.defer();

        return deferred.promise;
    };

    this.GetAll = function () {
        $http.get('/Category/GetAll', { data: {} }).then(
          function (result) {
              deferred.resolve(result.data);
          });
        var deferred = $q.defer();

        return deferred.promise;
    };

});