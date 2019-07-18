/*!-----------------------------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * monaco-languages version: 1.7.0(06ba3ff7e80720fda9a83bce89dbe13ed389b69e)
 * Released under the MIT license
 * https://github.com/Microsoft/monaco-languages/blob/master/LICENSE.md
 *-----------------------------------------------------------------------------*/
define("vs/basic-languages/lua/lua", ["require", "exports"], function(e, n) {
    "use strict";
    Object.defineProperty(n, "__esModule", {
        value: !0
    }), n.conf = {
        comments: {
            lineComment: "--",
            blockComment: ["--[[", "]]"]
        },
        brackets: [
            ["{", "}"],
            ["[", "]"],
            ["(", ")"]
        ],
        autoClosingPairs: [{
            open: "{",
            close: "}"
        }, {
            open: "[",
            close: "]"
        }, {
            open: "(",
            close: ")"
        }, {
            open: '"',
            close: '"'
        }, {
            open: "'",
            close: "'"
        }],
        surroundingPairs: [{
            open: "{",
            close: "}"
        }, {
            open: "[",
            close: "]"
        }, {
            open: "(",
            close: ")"
        }, {
            open: '"',
            close: '"'
        }, {
            open: "'",
            close: "'"
        }]
    }, n.language = {
        defaultToken: "",
        tokenPostfix: ".lua",
        keywords: ["and", "break", "do", "else", "elseif", "end", "false", "for", "function", "goto", "if", "in", "local", "nil", "not", "or", "repeat", "return", "then", "true", "until", "while"],
        globals: [
            'assert', 'collectgarbage', 'error', 'getfenv', 'getmetatable',
            'ipairs', 'loadfile', 'loadstring', 'newproxy', 'next', 'pairs',
            'pcall', 'print', 'rawequal', 'rawget', 'rawset', 'select', 'setfenv',
            'setmetatable', 'tonumber', 'tostring', 'type', 'unpack', 'xpcall', '_G',
            'shared', 'delay', 'require', 'spawn', 'tick', 'typeof', 'wait', 'warn',
            'game', 'Enum', 'script', 'workspace'
		],
		syn: ['hookfunction', 'mousemoverel','is_synapse_function','getgenv', 'keyrelease', 'setclipboard', 'mouse2press', 'getsenv', 'checkcaller', 'bit', 'debug', 'writefile', 'mousescroll', 'mouse2click', 'islclosure', 'mouse1press', 'mouse1release', 'keypress', 'mouse2release', 'newcclosure', 'getinstances', 'getnilinstances', 'readfile', 'getscripts', 'getrunningscripts', 'appendfile', 'listfiles', 'isfile', 'isfolder', 'delfolder', 'delfile', 'getreg', 'getgc', 'mouse1click', 'getrawmetatable', 'setreadonly', 'isreadonly', 'getrenv', 'decompile', 'dumpstring', 'getloadedmodules', 'isrbxactive', 'getcallingscript', 'setnonreplicatedproperty', 'getconnections', 'getspecialinfo', 'messagebox', 'messageboxasync', 'rconsolename', 'rconsoleinput', 'rconsoleinputasync', 'rconsoleprint', 'rconsoleinfo', 'rconsolewarn', 'rconsoleerr', 'fireclickdetector', 'firetouchinterest', 'saveinstance', 'syn'
        ],
        brackets: [{
            token: "delimiter.bracket",
            open: "{",
            close: "}"
        }, {
            token: "delimiter.array",
            open: "[",
            close: "]"
        }, {
            token: "delimiter.parenthesis",
            open: "(",
            close: ")"
        }],
        operators: ["+", "-", "*", "/", "%", "^", "#", "==", "~=", "<=", ">=", "<", ">", "=", ";", ":", ",", ".", "..", "..."],
        symbols: /[=><!~?:&|+\-*\/\^%]+/,
        escapes: /\\(?:[abfnrtv\\"']|x[0-9A-Fa-f]{1,4}|u[0-9A-Fa-f]{4}|U[0-9A-Fa-f]{8})/,
        tokenizer: {
            root: [
                [/[a-zA-Z_]\w*/, {
                    cases: {
                        "@keywords": {
                            token: "keyword.$0"
                        },
                      	"@globals": { token: "global" },
						"@syn": { token: "syn" },
                        "@default": "identifier"
                    }
                }], {
                    include: "@whitespace"
                },
                [/(,)(\s*)([a-zA-Z_]\w*)(\s*)(:)(?!:)/, ["delimiter", "", "key", "", "delimiter"]],
                [/({)(\s*)([a-zA-Z_]\w*)(\s*)(:)(?!:)/, ["@brackets", "", "key", "", "delimiter"]],
                [/[{}()\[\]]/, "@brackets"],
                [/@symbols/, {
                    cases: {
                        "@operators": "delimiter",
                        "@default": ""
                    }
                }],
                [/\d*\.\d+([eE][\-+]?\d+)?/, "number.float"],
                [/0[xX][0-9a-fA-F_]*[0-9a-fA-F]/, "number.hex"],
                [/\d+?/, "number"],
                [/[;,.]/, "delimiter"],
                [/"([^"\\]|\\.)*$/, "string.invalid"],
                [/'([^'\\]|\\.)*$/, "string.invalid"],
                [/"/, "string", '@string."'],
                [/'/, "string", "@string.'"]
            ],
            whitespace: [
                [/[ \t\r\n]+/, ""],
                [/--\[([=]*)\[/, "comment", "@comment.$1"],
                [/--.*$/, "comment"]
            ],
            comment: [
                [/[^\]]+/, "comment"],
                [/\]([=]*)\]/, {
                    cases: {
                        "$1==$S2": {
                            token: "comment",
                            next: "@pop"
                        },
                        "@default": "comment"
                    }
                }],
                [/./, "comment"]
            ],
            string: [
                [/[^\\"']+/, "string"],
                [/@escapes/, "string.escape"],
                [/\\./, "string.escape.invalid"],
                [/["']/, {
                    cases: {
                        "$#==$S2": {
                            token: "string",
                            next: "@pop"
                        },
                        "@default": "string"
                    }
                }]
            ]
        }
    }
});