﻿define(
    [
        'app.tasks',
        'angular'
    ],
    function (module) {
        'use strict';
        module.service('tasksService',
            function () {
                this.tasks = [
                    { name: 'task1', complete: 'true' },
                    { name: 'task1', complete: 'false' },
                    { name: 'task1', complete: 'true' },
                    { name: 'task1', complete: 'false' },
                    { name: 'task1', complete: 'true' },
                    { name: 'task1', complete: 'true' }
                ];

            }
        );
    });