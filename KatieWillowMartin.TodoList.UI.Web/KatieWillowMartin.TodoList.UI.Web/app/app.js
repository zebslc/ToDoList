define([
    'angular',
    'tasks/tasks.module'
], function(ng) {
    'use strict';

    return ng.module('app', [
        'app.tasks'
    ]);
});