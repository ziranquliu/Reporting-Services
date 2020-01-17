$.extend({queryString:{get:function(key){var search=window.location.search;if(search.length<1){return;}
if(key&&search.indexOf(key)<0){return;}
search=search.substring(1);search=decodeURI(search);var searchArr=search.split("&");var searchJSON={};$.each(searchArr,function(index,item){var item=item.split("=");searchJSON[item[0]]=item[1];});if(key){return searchJSON[key];}else{return searchJSON;}},set:function(data,url,isOpen){if(!data||$.type(data)!='object'){return;}
var pathname=url||window.location.pathname;var str="?",index=0;if($.isEmptyObject(data)){str="";}else{$.each(data,function(key,val){str+=(index>0?"&":"")+key+"="+val;index++;});}
if(isOpen){window.open(pathname+str);}else{window.location.href=pathname+str;}},add:function(data,url,isOpen){if(!data||$.type(data)!='object'){return;}
var query=this.get();if(query){$.each(query,function(key,val){if(!data.hasOwnProperty(key)){data[key]=val;}});}
this.set(data,url,isOpen);},update:function(data,url,isOpen){if(!data||$.type(data)!='object'){return;}
var query=this.get();if(query){$.each(data,function(key,val){if(query.hasOwnProperty(key)){query[key]=val;}});}
this.set(query,url,isOpen);},delete:function(data,url,isOpen){if(!data||$.type(data)!='array'){return;}
var query=this.get();if(data.length==0){query={};}else{$.each(data,function(index,item){if(query.hasOwnProperty(item)){delete query[item];}});}
this.set(query,url,isOpen);}}});