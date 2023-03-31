(function(){
  'use strict';
  
  var Wizard = function($compile) {
    var _link = function(scope, elem, attr, ctrl){
          elem.wrapInner('<div class="wizard"></div>');
          
        var _options = ctrl.stepsOptions,
            _stepsConfig = {
              headerTag: 'h1',
              bodyTag: 'div',
              transitionEffect: $.fn.steps.transitionEffect.none,
              autoFocus: true,
              contentMode: 'html',
              titleTemplate: '#title#',
              enableFinishButton: true,
              showFinishButtonAlways: false,
              stepsOrientation: _options.stepsOrientation,
              onStepChanging: _options.stepChanging,
              onstepChanged: _options.stepChanged,
              onCanceled: _options.stepCanceled,
              onFinishing: _options.stepFinishing, 
              onFinished: _options.stepFinished,
              labels: {
                  cancel: 'Cancel',
                  current: 'current step:',
                  pagination: 'Pagination',
                  finish: 'Save',
                  next: 'Next',
                  previous: 'Previous'
              }
          },
          
          _steps = elem.children('.wizard').steps(_stepsConfig);
          
        $compile(_steps)(scope);
     };
     
    return {
      restrict: 'EA',
      template: '<div ng-transclude></div>',
      controller: '@',
      name: 'ctrl',
      controllerAs: 'wizard',
      transclude: true,
      scope: {
        name: '@'
      },
      link: _link,
      replace: true
    };
  };
  
  angular.
    module('widgets').
      directive('wizard', ['$compile', Wizard]);
}());