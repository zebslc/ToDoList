define(
    [
      'app.tasks'
    , 'angular'
    ],

    function (module) {
    'use strict';

    module.controller('tasks', tasks);

    function tasks($location, $scope) {

        $scope.tasks = [
            { name: 'task1', complete: 'true' },
            { name: 'task1', complete: 'false' },
            { name: 'task1', complete: 'true' },
            { name: 'task1', complete: 'false' },
            { name: 'task1', complete: 'true' },
            { name: 'task1', complete: 'true' }
        ];

        $scope.delete = function(idx) {
            $scope.tasks.splice(idx, 1);
        }
    }
});