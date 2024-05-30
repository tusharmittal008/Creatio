define("UsrRealtyMigration_ListPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "MenuItem_ImportFromExcel",
				"values": {
					"clicked": {
						"request": "crt.ImportDataRequest",
						"params": {
							"entitySchemaName": "UsrRealtyClassic"
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "FolderTree",
				"values": {
					"sourceSchemaName": "UsrRealtyClassicFolder",
					"rootSchemaName": "UsrRealtyClassic"
				}
			},
			{
				"operation": "merge",
				"name": "DataTable",
				"values": {
					"columns": [
						{
							"id": "db6e0da3-3e8e-9847-1e5c-ed18e02ca21d",
							"code": "PDS_UsrName",
							"caption": "#ResourceString(PDS_UsrName)#",
							"dataValueType": 28
						},
						{
							"id": "01e92a62-7c8b-2d6c-ba19-adb7634d11d0",
							"code": "PDS_UsrPriceUSD",
							"caption": "#ResourceString(PDS_UsrPriceUSD)#",
							"dataValueType": 32
						},
						{
							"id": "756ec5d2-69ff-22cb-c3e5-fa5fb56999ae",
							"code": "PDS_UsrType",
							"caption": "#ResourceString(PDS_UsrType)#",
							"dataValueType": 10
						},
						{
							"id": "1cdc287e-8fea-a559-950b-bada8e4f35c9",
							"code": "PDS_UsrOfferType",
							"caption": "#ResourceString(PDS_UsrOfferType)#",
							"dataValueType": 10
						},
						{
							"id": "8a71464e-fe81-aa24-14c7-c76e64e0e97f",
							"code": "PDS_UsrComment",
							"caption": "#ResourceString(PDS_UsrComment)#",
							"dataValueType": 30
						},
						{
							"id": "8b12f7fc-ca33-6b71-5810-9a201d5a3a32",
							"code": "PDS_CreatedOn",
							"caption": "#ResourceString(PDS_CreatedOn)#",
							"dataValueType": 7
						}
					]
				}
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes",
					"Items",
					"viewModelConfig",
					"attributes"
				],
				"values": {
					"PDS_UsrName": {
						"modelConfig": {
							"path": "PDS.UsrName"
						}
					},
					"PDS_UsrPriceUSD": {
						"modelConfig": {
							"path": "PDS.UsrPriceUSD"
						}
					},
					"PDS_UsrType": {
						"modelConfig": {
							"path": "PDS.UsrType"
						}
					},
					"PDS_UsrOfferType": {
						"modelConfig": {
							"path": "PDS.UsrOfferType"
						}
					},
					"PDS_UsrComment": {
						"modelConfig": {
							"path": "PDS.UsrComment"
						}
					},
					"PDS_CreatedOn": {
						"modelConfig": {
							"path": "PDS.CreatedOn"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"dataSources",
					"PDS",
					"config"
				],
				"values": {
					"entitySchemaName": "UsrRealtyClassic",
					"attributes": {
						"UsrName": {
							"path": "UsrName"
						},
						"UsrPriceUSD": {
							"path": "UsrPriceUSD"
						},
						"UsrType": {
							"path": "UsrType"
						},
						"UsrOfferType": {
							"path": "UsrOfferType"
						},
						"UsrComment": {
							"path": "UsrComment"
						},
						"CreatedOn": {
							"path": "CreatedOn"
						}
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});