
angular
    .module('app')
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        // Specify the three simple routes ('/', '/About', and '/Contact')
        $routeProvider.when('/tasks/list', {
            templateUrl: '/Home/Index'
        });
    
        $routeProvider.otherwise({
            redirectTo: '/'
        });

        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');

    }]);
