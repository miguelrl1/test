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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity23 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity25 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity26 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity24 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence22 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV28Input,RESTActivityV28Output> RESTActivityV28 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse16Input> IfElse16 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV212Input,RESTActivityV212Output> RESTActivityV212 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse19Input> IfElse19 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch17 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch18 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch20 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch21 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV29Input,RESTActivityV29Output> RESTActivityV29 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV210Input,RESTActivityV210Output> RESTActivityV210 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV211Input,RESTActivityV211Output> RESTActivityV211 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV215Input,RESTActivityV215Output> RESTActivityV215 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV213Input,RESTActivityV213Output> RESTActivityV213 = null;
    public HP.ST.Ext.RestActivity.RESTActivityV2<RESTActivityV214Input,RESTActivityV214Output> RESTActivityV214 = null;
    
    }
    
    }
    