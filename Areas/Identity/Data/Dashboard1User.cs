﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Dashboard1.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Dashboard1User class
public class Dashboard1User : IdentityUser
{ 
	
	public string FirstFName3 { get; set; }
	public string LastLName3 { get; set; }
}

