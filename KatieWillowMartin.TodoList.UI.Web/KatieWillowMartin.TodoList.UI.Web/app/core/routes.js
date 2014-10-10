(function() {
    'use strict';

    var core = angular.module('app.core');

    core.config(
        function($routeProvider, $locationProvider) {
            $routeProvider.
                when('/home/index/tasks', {
                    templateUrl: '/app/tasks/task-list.html',
                    controller: 'tasks'
                }).
                otherwise({
                    redirectTo: '/'
                });
            $locationProvider.html5Mode(true);
        });
})();