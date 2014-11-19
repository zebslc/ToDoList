define(
    [
        'app.core',
        'angular'
    ],

    function (module) {
        'use strict';

        return module.config(['$routeProvider', '$locationProvider',
            function ($routeProvider, $locationProvider) {
                $routeProvider.
                    when('/tasks/list', {
                        templateUrl: '/app/tasks/task-list.html',
                        controller: 'tasks'
                    }).
                    otherwise({
                        redirectTo: '/'
                    });
                $locationProvider.html5Mode(true);
            }]);
    });
