global using System.ComponentModel.DataAnnotations.Schema;
global using System.Linq.Expressions;

global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Infrastructure;
global using Microsoft.EntityFrameworkCore.Query;
global using Microsoft.Extensions.DependencyInjection;

global using Pavon.Domain.Abstractions.Repositories.Commands;
global using Pavon.Domain.Abstractions.Repositories.Queries;
global using Pavon.Domain.Abstractions.UnitOfWorks.Commands;
global using Pavon.Domain.Abstractions.UnitOfWorks.Queries;
global using Pavon.Domain.Entities.DomainEntities;
global using Pavon.Domain.Entities.Identity;

namespace Pavon.Domain;
