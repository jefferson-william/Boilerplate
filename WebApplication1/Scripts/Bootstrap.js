'use strict';

require.config({
    baseUrl: '/Scripts',
    paths: {
		'Angular': '../Content/Components/angular/angular',
		'AngularAnimate': '../Content/Components/angular-animate/angular-animate',
		'AngularAria': '../Content/Components/angular-aria/angular-aria',
		'AngularMaterial': '../Content/Components/angular-material/angular-material',
		'AngularMessages': '../Content/Components/angular-messages/angular-messages',
		'Main': 'Main'
    }
});

require([
    'Main'
], function (Main) {
    console.log('Hello!');
});
