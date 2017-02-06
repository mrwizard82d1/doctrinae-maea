# .NET Security

## Before 4.5

Before .NET 4.5, Windows authentication and authorization were based on `IIdentity` (authentication) and `IPrincipal`
(authorization). Here are the key classes before .NET 4.5

![.NET Acn and Azn Before 4.5](/dotnet-security/dotnet-security-b4-45.png)

## 4.5 and Later

.NET 4.5 moved to claims-based authentication and authorization. 

![.NET 4.5 Acn and Azn](/dotnet-security/dotnet-security-45.png)

In addition to introducing `Claims`, NET 4.5 changed the inheritance structure so that "legacy" classes derive from
`ClaimsIdentity` and `ClaimsPrincipal`

![.NET 4.5 IPrincipalInheritance](/dotnet-security/dotnet-security-45-inherit.png)

Here are some resources on .NET 4.5 security (from the Pluralsight course, "Identity and Access Control in ASP.NET 4.5").

## Resources

* Introductory Pluralsight (http://pluralsight.com): "Introduction to Identity & Access Control in .NET 4.5"
* Book "Guide to Claims-based Identity & Access Control" (http://www.tinyurl.com/claimsguide2)
* Helper methods to utilize the .NET 4.5 identity model (https://github.com/identitymodel/Thinktecture.IdentityModel)
* Starter identity server (https://github.com/IdentityServer/IdentityServer3). See the README file to reference the
  sample plug-ins.

### Claim Examples

A claim is a statement about an entity by someone (or something) else. Here are some examples of claims. (The claims
details do not reflect the exact details of production or .NET code.)

![Bob is an administrator](/dotnet-security/administrator-claim.png)
![Alice has an email address](/dotnet-security/email-claim.png)
![Carol acts on behalf of Alice](/dotnet-security/on-behalf-of-claim.png)

