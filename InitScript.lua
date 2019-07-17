--[[

	InitScript.lua

	This script defines globals used by Gamer UI. Not much can be done with this, but there's
	an example of how to use addGlobal() below.

]]

local genv = getgenv()

genv.GamerUIBackup = {}
local backupTbl = genv.GamerUIBackup

local function backupTbl:RestoreGenv()
	for i,v in pairs(backupTbl) do
		genv[i] = v
		v = nil
	end
end

local function addGlobal(name,val) --// void addGlobal(string Name, <variant> Value) Adds a value to the global environment
	if genv[name] then
		backupTbl[name] = genv[name]
	end
	genv[name] = val
end

addGlobal("getfortnite",function()
	return {"fortnite"}
end)