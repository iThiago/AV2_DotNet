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
            }).
            when('/', {
                templateUrl: 'Scripts/App/home.html'
            }).
            otherwise({
                redirectTo: '/'
            });
    }
]);