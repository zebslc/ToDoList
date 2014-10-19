define(
    [
      'app.tasks'
    , 'angular'
    ],

    function (module) {
    'use strict';

    module.controller('tasks', tasks);

    function tasks($location, $scope, tasksService) {

        $scope.tasks=tasksService.tasks;

        $scope.delete = function(idx) {
            $scope.tasks.splice(idx, 1);
        }
    }
});