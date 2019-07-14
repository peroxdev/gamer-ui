local genv = getgenv()

genv.GamerUIBackup = {}
local backupTbl = genv.GamerUIBackup

local function backupTbl:RestoreGenv()
	for i,v in pairs(backupTbl) do
		genv[i] = v
		v = nil
	end
end

local function addGlobal(name,val)
	if genv[name] then
		backupTbl[name] = genv[name]
	end
	genv[name] = val
end

addGlobal("getfortnite",function()
	return {"fortnite"}
end)