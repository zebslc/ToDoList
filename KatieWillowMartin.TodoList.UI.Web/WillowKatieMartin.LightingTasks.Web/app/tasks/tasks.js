define(
    [
        'app.tasks',
        'angular'
    ],

    function (module) {
        'use strict';

        module.controller('tasks', tasks);

        function tasks($scope, tasksService) {

            $scope.tasks = tasksService.tasks.query();

            function resetTaskInput() {
                $scope.name="";
            }

            $scope.add=function(){
                tasksService.tasks.splice(0,0,{
                    name: $scope.name,
                    complete: false
                });

                resetTaskInput();

            };

            $scope.delete = function (idx) {
                tasksService.tasks.splice(idx, 1);
            };

            $scope.complete=function(idx) {
                var oldStatus = $scope.tasks[idx].complete;
                $scope.tasks[idx].complete = !oldStatus;
            };
        }
    });