--[[

	InitScript.lua

	This script defines globals used by Gamer UI. Not much can be done with this, but there's
	an example of how to use addGlobal() below.

]]

local genv = getgenv()

local backupTbl = genv.GamerUIBackup

local function addGlobal(name,val) --// void addGlobal(string Name, <variant> Value) Adds a value to the global environment
	genv[name] = val
end

addGlobal("getfortnite",function()
	return {"fortnite"}
end)