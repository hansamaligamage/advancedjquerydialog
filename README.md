# Advanced Jquery dialog
This sample code demonstrates how to show a JQuery confirm dialog box in ASP.NET Core application. It has focused how to use same div tag with confirmation dialog in different actions. Also it has showed how to pass multiple parameters into JQuery dialog and process it later in different stages in dialog box.

This code snippet shows different actions performed in the application (click on a link, click on different buttons) in each different actions, it passes type of the action and other necessary parameters to process further things

```
 $('a[id*=btnRemove]').click(function (e) { 
     debugger; 
     e.preventDefault(); 
     var id = $(this).parent()[0].id; 
     var data = $('#confirmDialog').data(); 
     data.type = 1; 
     data.module = id; 
     $('#confirmDialog').dialog('open'); 
  }); 
 
  $('input[id*=btnImageRemove]').click(function () { 
      var id = $(this).parent()[0].id; 
      var data = $('#confirmDialog').data(); 
      data.type = 2; 
      data.id = id; 
      $('#confirmDialog').dialog('open'); 
   }); 
 
   $('input[id*=btnVideoRemove]').click(function () { 
       var id = $(this).parent()[0].id; 
       var data = $('#confirmDialog').data(); 
       data.type = 3; 
       data.id = id; 
       $('#confirmDialog').dialog('open'); 
    });
```

In below code snippet, it shows JQuery confirm dialog box initialization, in all the above button clicks it calls same JQuery dialog box with same div tags. When click on OK button in dialog box, it performs different actions based on type, if you can see more into this, it shows how to extract parameters passed from different places.

```
 $("#confirmDialog").dialog({ 
      autoOpen: false, 
      modal: true, 
      resizable: false, 
      buttons: { 
          "Ok": function () { 
               var type = $(this).data('type'); 
               if (type == 1) { // remove a module 
                   var module = $(this).data('module'); 
                   window.location.href = '/Home/RemoveModule?id=' + module; 
                    } 
               else // remove an image or video 
               { 
                   var id = $(this).data('id'); 
                   window.location.href = '/Home/RemoveResource?id=' + id + '&type=' + type; 
               } 
                }, 
          "Cancel": function (e) { 
               $(this).dialog("close"); 
            } 
         }, 
    });
```
    
Continue to read more on how to pass multiple parameters to a JQuery dialog and process many actions with same JQuery dialog based on those parameters, go through this article <a href="https://social.technet.microsoft.com/wiki/contents/articles/38122.asp-net-core-advanced-jquery-dialog-actions.aspx">ASP.NET  Core : Advanced JQuery dialog actions</a>
      
You can check this article to know how to show a simple confirmation dialog, <a href="https://social.technet.microsoft.com/wiki/contents/articles/37986.asp-net-core-how-to-show-a-confirmation-dialog-with-jquery.aspx ">ASP.NET Core : How to show a confirmation  dialog with jquery</a>
