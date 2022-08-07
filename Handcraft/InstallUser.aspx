<%@ Page Language="C#" AutoEventWireup="true" %> 
<% 
   try 
   { 
      Roles.CreateRole("Administrators"); 
   } 

   catch (Exception) { } 

   try 
   { 
      var user = Membership.CreateUser("episerver", "episerver", "episerver@episerver.com"); 
      user.IsApproved = true; 
    }
    catch (Exception) {}

    try
    {
        Roles.AddUserToRole("episerver", "Administrators"); 
    }
    catch (Exception) {} 
%> 