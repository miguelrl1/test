using System;
    using System.Collections.Generic;
    using System.Text;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    
    namespace Script
    {
    
    public class TestEntities
    {
    public ISTRunTimeContext Context = null;
    public Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource> dataSourceNameToDataSource = new Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource>();
    
    protected HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource GetDataSource(string dataSourceName)
    {
    if(!dataSourceNameToDataSource.ContainsKey(dataSourceName))
    	throw new Exception(("A data source with the specified name does not exist."));
    return dataSourceNameToDataSource[dataSourceName];
    }
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity26 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity28 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity29 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity27 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence25 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV217Input,RESTActivityV217Output> RESTActivityV217 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV218Input,RESTActivityV218Output> RESTActivityV218 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV219Input,RESTActivityV219Output> RESTActivityV219 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV220Input,RESTActivityV220Output> RESTActivityV220 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV221Input,RESTActivityV221Output> RESTActivityV221 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV222Input,RESTActivityV222Output> RESTActivityV222 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV223Input,RESTActivityV223Output> RESTActivityV223 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV224Input,RESTActivityV224Output> RESTActivityV224 = null;
    
    }
    
    }
    