app.controller('FornecedorController', function ($scope, $http, $location) {
    $scope.save = function () {
        if ($scope.Cnpj === "") {
            alert("CNPJ invalido.");
            return;
        }
        if ($scope.RazaoSocial === "") {
            alert("Razao Social invalida.");
            return;
        }

        $http.post('/Fornecedor/SaveFornecedor', {
            RazaoSocial: $scope.RazaoSocial,
            Cpnj: $scope.Cpnj,
            InscricaoMunicipal: $scope.InscricaoMunicipal,
            ReceitaBruta: $scope.ReceitaBruta
        }).then(function () {
            $scope.name = "";
            $scope.stock = "";
            $scope.brand = "";
            alert("Fornecedor salvo com sucesso.");
        }, function (error) {
            alert(error.Message);
            console.log(error);
        });
    };

    $scope.AddEndereco = function () {
        //$scope.Enderecos.a
    };


});