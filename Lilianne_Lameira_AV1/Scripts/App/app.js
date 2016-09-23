var app = angular.module('Lili', ['ngRoute']);

app.controller('MasterController', function ($scope) {
});


app.config([
    '$routeProvider',
    function ($routeProvider) {
        $routeProvider.
            when('/adicionar/produto', {
                templateUrl: 'Scripts/App/product/views/add.html',
                controller: 'AddProductController'
            }).when('/adicionar/fornecedor', {
                templateUrl: 'Scripts/App/fornecedor/views/addFornecedor.html',
                controller: 'FornecedorController'
            }).
            when('/', {
                templateUrl: 'Scripts/App/home.html'
            }).
            otherwise({
                redirectTo: '/'
            });
    }
]);