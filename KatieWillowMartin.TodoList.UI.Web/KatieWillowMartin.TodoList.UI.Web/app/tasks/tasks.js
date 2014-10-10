(function() {
    'use strict';

    angular
        .module('app.tasks')
        .controller('tasks', tasks);

    tasksModule.$inject =
    [
        '$location', '$scope', '$routeParams', '$window',
        'config'
    ];

    function tasks($location, $scope, $routeParams, $window, config) {
        $scope.message = 'test';
    }


})();