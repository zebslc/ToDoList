define(
    [
        'app.core',
        'angular',
        'uiRouter'
    ],

    function (module) {
        'use strict';

        return module.config([
            '$stateProvider',
            function ($stateProvider) {

                $stateProvider.state('list', {
                    url: '/list',
                    templateUrl: '/app/tasks/task-list.html',
                    controller: 'tasks'
                })

                .state('home', {
                    url: '/home',
                    views:{
                        '':{templateUrl:'/app/core/layout.html'},
                        'tasks@home':{
                            templateUrl:'/app/tasks/task-list.html',
                            controller: 'tasks'
                        }
                    }

                       })
                ;

            }]);
    });
