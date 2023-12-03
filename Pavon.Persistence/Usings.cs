global using System.Linq.Expressions;
global using System.Reflection;

global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Diagnostics;
global using Microsoft.EntityFrameworkCore.Query;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;

global using Pavon.Application.Interfaces.Context;
global using Pavon.Domain.Abstractions.Common;
global using Pavon.Domain.Abstractions.Repositories.Commands;
global using Pavon.Domain.Abstractions.Repositories.Queries;
global using Pavon.Domain.Abstractions.UnitOfWorks;
global using Pavon.Domain.Abstractions.UnitOfWorks.Commands;
global using Pavon.Domain.Abstractions.UnitOfWorks.Queries;
global using Pavon.Domain.Entities.DomainEntities;
global using Pavon.Domain.Entities.Identity;
global using Pavon.Persistence.Context;
global using Pavon.Persistence.Repositories.Commands;
global using Pavon.Persistence.Repositories.Queries;
global using Pavon.Persistence.UnitOfWorks;
global using Pavon.Persistence.UnitOfWorks.Commands;
global using Pavon.Persistence.UnitOfWorks.Queries;
namespace Pavon.Persistence;