define(
    [
        'app.tasks',
        'angular',
        'ngResource'
    ],
    function (module) {
        'use strict';
        module.service('tasksService',
            function ($resource) {
                this.tasks= function(){
                    var tasksData=$resource("api/tasks/");
                    return tasksData.get();
                }();
            }
        );
    });
/**
 this.tasks = [
 { name: 'task1', complete: true },
 { name: 'task1', complete: false },
 { name: 'task1', complete: true },
 { name: 'task1', complete: false },
 { name: 'task1', complete: true },
 { name: 'task1', complete: true }
 ];
 **/