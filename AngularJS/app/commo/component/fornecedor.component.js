
angular.module('myApp')
.component('fornecedorModal', {
    template: `<div class="modal-header">
    <button type="button" ng-click="$ctrl.handleDismiss()" class="close" data-dismiss="modal" aria-label="Close">
      <span aria-hidden="true">×</span></button>
    <h2 class="modal-title">Buscar fornecedor</h2>
  </div>
<!-- HEADER -->

<div class="jumbotron margem-detail">
    <!--button type="button" class="close" data-dismiss="modal" aria-label="Close">
    <span aria-hidden="true">×</span></button-->
    <div class="modal-body">

    <h2>Fornecedor</h2>

    <form  ng-submit="$ctrl.searchFornecedor()">
            <div class="form-group">
                <div class="row">
                    <div class="col-md-4">
                        ID : <input type="text" ng-model="$ctrl.Filter.id" class="form-control" />
                    </div>
                    <div class="col-md-4">
                        Razão Social : <input type="text" ng-model="$ctrl.Filter.razaoSocial" class="form-control" />
                    </div>
                    <div class="col-md-4"  style="padding-top: 2%;">
                        <button class="btn btn-small btn-primary">Filtrar</button>
                    </div>
                </div>   
                         
            </div>
        </form>
        
       
        <div class="table-responsive"></div>
        <table class="table" ng-show="$ctrl.lista.value.length > 0">
            <thead class="thead-light">
                <tr>
                    <th >ID</a></th>
                    <th>Razão Social</a></th>
                    <th>CNPJ</a></th>
                    <th>Telefone</a></th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="item in $ctrl.lista.value track by $index"> <!-- | filter: {titulo: criterioDeBusca} | filter: {status: selectedStatus} -->
                    <td>{{item.ID}}</td>
                    <td>{{item.RAZAO_SOCIAL}}</td>
                    <td>{{item.CNPJ}}</td>
                    <td>{{item.TELEFONE}}</td>
                    <td><a ng-click="$ctrl.handleClose(item.ID, item.RAZAO_SOCIAL, item.CNPJ, item.TELEFONE)" class="btn btn-small btn-primary">Selecionar</a></td>
                </tr>
            </tbody>
        </table>
</div>
</div>

<!-- FOOTER -->
<!--div class="modal-footer">
    <button type="button" ng-click="$ctrl.handleClose()" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
    <button type="button" class="btn btn-primary">Save changes</button>
  </div-->`,
    bindings: {
        $close: '&',
        $dismiss: '&',
        modalData: '<',
        //tarefa: '<'
    },
    controller: ['$http', 'consts', 'Fornecedor', function($http, consts, Fornecedor) {
        var $ctrl = this;

        $ctrl.Filter = {
            id : '',
            name :  ''
        }

        $ctrl.searchFornecedor = () => {
            const a = Fornecedor.searchFornecedor($ctrl.Filter.id, $ctrl.Filter.name)
            $ctrl.lista = a.$$state
        }

        $ctrl.handleClose = function(id, name, unitValue, stock) {
            //console.info("in handle close");
            $ctrl.$close({
                result: {
                    id, 
                    name,
                    unitValue,
                    stock
                }                
            });
        };

        $ctrl.handleDismiss = function() {
            //console.info("in handle dismiss");
            $ctrl.$dismiss({
                reason: 'cancel'
            });
        };

    }],
});
