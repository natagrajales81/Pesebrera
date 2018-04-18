(function () {
    angular.module("appBovinosEquinos", [])
.controller("appBovinosEquinosController", function ($scope, $http) {
    
    $scope.retData = {};
    $scope.retData.generarResultados = function (item, event) {
       
        $http.post('../SERVICIOS/ServicioGeneracion.aspx/Generar', { data: {} }, { dataType: 'json' })
        .success(function ( status, headers, config) {
            alert("Exitoso");
            
        })
        .error(function (status, headers, config) {
            alert("Fallo");
            $scope.status = status;
        });
    }
}).config(function ($httpProvider) {
    $httpProvider.defaults.headers.post = {};
    $httpProvider.defaults.headers.post["Content-Type"] = "application/json; charset=utf-8";
});

})();