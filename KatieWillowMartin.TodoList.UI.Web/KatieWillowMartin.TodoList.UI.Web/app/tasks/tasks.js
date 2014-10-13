define(
    [
      'app.tasks'
    , 'angular'
    ],
    function (module) {
    'use strict';

    module.controller('tasks', tasks);

    function tasks($location, $scope) {
        $scope.message = 'test';
    }


});