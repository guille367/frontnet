angular.module("ngApp").controller("MyController", ["$scope", "MyService", function ($scope, MyService) {
    $scope.prueba = "Funca";

    $scope.btnPost = function () {
        MyService.postPrueba({ID: 2, Nombre: "Llegó y punto."})
            .then(function (a, q, e) {
                console.log("Todo bien");
                console.log(a);
                console.log(q);
                console.log(e);
            })
            .catch(function (a, q, e) {
                console.log("Todo mal");
                console.log(a);
                console.log(q);
                console.log(e);
            });
    }

    $scope.btnGet = function () {
        MyService.getPrueba()
            .then(function (a,q,e) {
                console.log("Todo bien");
                console.log(a);
                console.log(q);
                console.log(e);
            })
            .catch(function (a, q, e) {
                console.log("Todo mal");
                console.log(a);
                console.log(q);
                console.log(e);
            });
    }

}]);