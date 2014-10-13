require.config({

    // alias libraries paths
    paths: {
        'domReady': '../Scripts/domReady',
        'angular': '../Scripts/angular',
        'angular-route': '../Scripts/angular-route',
        'app': '../app/app.module'
    },

    // angular does not support AMD out of the box, put it in a shim
    shim: {
        'angular':
            {
                'exports': 'angular'
            },
        'angular-route':
            {
                'deps': ['angular'],
                'exports': 'angular-route'
            }
        },
    
    // kick start application
    deps:
        [
        './bootstrap'
        ]
});