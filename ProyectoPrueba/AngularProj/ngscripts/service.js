angular.module("ngApp").service("MyService", ["$http", function ($http) {

    let postPrueba = function (objeto) {
        return $http.post("/api/AsyncPrueba/PostPersona", objeto);
    };

    let getPrueba = function () {
        return $http.get("/api/AsyncPrueba/GetPersona", {});
    };


    return {
        postPrueba: postPrueba,
        getPrueba: getPrueba,
    };

}]);