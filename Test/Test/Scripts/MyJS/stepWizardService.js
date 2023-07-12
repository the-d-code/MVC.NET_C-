(function(){
  'use strict';
  
  var StepWizard = function(){},
      StepWizardService = function(){
        return new StepWizard();
      };
  
  StepWizard.prototype = function(){
    var _handler = {
      stepChanging: function(getValidator, e, current, next) {
        var _validator = getValidator(current, next);
        
        if(next > current) return _validator.validate();
        
        _validator.hideMessages();
        
        return true;
      },
      
      stepChanged: function(e, currentIndex) {
        console.log('stepChanged!');
      },

      stepCanceled: function(e) {
        console.log('stepCanceled!');
      },

      stepFinishing: function(getValidator, e, current, next) {
        return getValidator(current, next).validate();
      },

      stepFinished: function(e, currentIndex, newIndex) {
        console.log('stepFinished!');
      },
      
      /* CountriesList options */
      
      emptySet: Object.create({}),
      
      countriesListOptions: {
        dataSource: {
          transport: {
            read: function(config){
              var _countries = [
                { name: 'Albania', value: 1 },
                { name: 'Andorra', value: 2 },
                { name: 'Armenia', value: 3 },
                { name: 'Belarus', value: 4 },
                { name: 'Belgium', value: 5 }
              ];
                
                setTimeout(config.success.bind(_handler.emptySet, _countries), 2000);
            }
          }
        },
        
        dataTextField: 'name',
        dataValueField: 'value',
        optionLabel: {
          name: 'Select',
          value: ''
        }
      },
      
      countriesListChange: function(e){
        console.log(e.sender.dataItem());
      }
    };
    
    return {
      stepChanging: _handler.stepChanging,
      stepChanged: _handler.stepChanged,
      stepCanceled: _handler.stepCanceled,
      stepFinishing: _handler.stepFinishing,
      stepFinished: _handler.stepFinished,
      countriesListOptions: _handler.countriesListOptions,
      countriesListChange: _handler.countriesListChange
    };
  }()
  
  angular.
    module('wizardModule').
      factory('stepWizardService', [StepWizardService]);
}());