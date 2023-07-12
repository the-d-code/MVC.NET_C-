(function(){
  'use strict';
  
  var StepWizardCtrl = function($scope, stepWizardService){
    var _vm = this;
    
    _vm.scope = $scope;
    
    _vm.name = 'Angular-jQuery Steps Wizard';
    
    _vm.scope.radio = { 
      current: 1,
      previous: 0
    };
    _vm.scope.$watch('radio', _vm.watch.radio.bind(_vm), true);
    
    _vm.stepsOptions = {
      orientation: 'horizontal',
      stepChanging: stepWizardService.stepChanging.bind(_vm.emptySet, _vm.getValidator.bind(_vm)),
      stepChanged: stepWizardService.stepChanged,
      stepCanceled: stepWizardService.stepCanceled,
      stepFinishing: stepWizardService.stepFinishing.bind(_vm.emptySet, _vm.getValidator.bind(_vm)),
      stepFinished: stepWizardService.stepFinished
    };
    
    /*
     * $scope.$on("kendoWidgetCreated", function(event, widget){
     *    if (widget === $scope.countriesList) $scope.countriesList.select(2);
     * });
    */
    
    _vm.countriesListOptions = stepWizardService.countriesListOptions;
    _vm.countriesListChange = stepWizardService.countriesListChange;
  };
  
  StepWizardCtrl.prototype = function(){
    var _handler = {
          emptySet: Object.create({}),
          
          validators: {
            0: ['firstStepValidator'],
            1: ['secondStepFirstValidator', 'secondStepSecondValidator']
          },
          
          nextValidatorIndex: 0,
          
          getValidator: function(current, next){
            if(_handler.verifyProp(next)) _handler.nextValidatorIndex = next;
            
            return this.scope[this.setValidator(current)];
          },
          
          watch: {
            radio: function(newVal, oldVal){
              if(_handler.verifyProp(newVal)){
              var _state = Number(newVal.current) === 0;
            
                this.scope.radio.previous = oldVal.current;
                
                 _handler.setup.validator.call(this)
                 _handler.setup.countriesList.call(this, _state);
                 _handler.setup.message.call(this, _state)
              }
            }
          },
          
          setup: {
            countriesList: function(state){
              this.scope.countriesList.enable(state);
            
              if(!state) this.scope.countriesList.select(0);
            },
            
            validator:function(){
                this.scope[_handler.setValidator.call(this, _handler.nextValidatorIndex)].hideMessages();
            },
            
            message: function(state){
              this.allowMessage = state;
              
              if(!state)this.message = '';
            }
          },
          
          verifyProp: function(prop){
            return (typeof prop !== 'undefined' && prop !== null);
          },
          
          setValidator: function(index){
            var _validatorsList = _handler.validators[index];
            
              return (_validatorsList.length === 1) ? _validatorsList[0] : _validatorsList[this.scope.radio.previous];
          }
        };
    
    return {
      emptySet: _handler.emptySet,
      validators: _handler.validators,
      getValidator: _handler.getValidator,
      watch: _handler.watch,
      setValidator: _handler.setValidator
    };
  }();
  
  StepWizardCtrl.$inject = ['stepWizardService'];
  
  angular.
    module('wizardModule').
      controller("stepWizardCtrl", ['$scope', 'stepWizardService', StepWizardCtrl]);
}());