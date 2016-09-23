app.controller('AddProductController', function ($scope, $http, $location) {
    $scope.save = function () {
        if ($scope.name === "") {
            alert("Nome invalido.");
            return;
        }
        if ($scope.stock === "") {
            alert("Estoque invalido.");
            return;
        }
        if ($scope.brand === "") {
            alert("Marca invalida.");
            return;
        }

        $http.post('/Product/SaveProduct', {
            Name: $scope.name,
            Stock: $scope.stock,
            Brand: $scope.brand
        }).then(function () {
            $scope.name = "";
            $scope.stock = "";
            $scope.brand = "";
            alert("Produto salvo com sucesso.");
        }, function (error) {
            alert(error.Message);
            console.log(error);
        });
    };
});