using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLangConsole.Moon.Token
{
    public enum Token
    {
        Null, New, Var,
        Throw, Delete, Void,

        int8, uint8,
        int16, uint16,
        int32, uint32,

        Char, Wchar, Dchar, 

        And, Or,

        Class, Struct,



        TOKint16, TOKuns16,
        TOKint32, TOKuns32,
        TOKint64, TOKuns64,
        TOKint128, TOKuns128,
        TOKfloat32, TOKfloat64, TOKfloat80,
        TOKimaginary32, TOKimaginary64, TOKimaginary80,
        TOKcomplex32, TOKcomplex64, TOKcomplex80,
        TOKchar, TOKwchar, TOKdchar, TOKbool,


        /*
        TOKreserved,

        // Other
        TOKlparen, TOKrparen,
        TOKlbracket, TOKrbracket,
        TOKlcurly, TOKrcurly,
        TOKcolon, TOKneg,
        TOKsemicolon, TOKdotdotdot,
        TOKeof, TOKcast,
        TOKnull, TOKassert,
        TOKtrue, TOKfalse,
        TOKarray, TOKcall,
        TOKaddress,
        TOKtype, TOKthrow,
        TOKnew, TOKdelete,
        TOKstar, TOKsymoff,
        TOKvar, TOKdotvar,
        TOKdotid, TOKdotti,
        TOKdottype, TOKslice,
        TOKarraylength, TOKversion,
        TOKmodule, TOKdollar,
        TOKtemplate, TOKdottd,
        TOKdeclaration, TOKtypeof,
        TOKpragma, TOKdsymbol,
        TOKtypeid, TOKuadd,
        TOKremove,
        TOKnewanonclass, TOKcomment,
        TOKarrayliteral, TOKassocarrayliteral,
        TOKstructliteral,
        TOKclassreference,
        TOKthrownexception,
        TOKdelegateptr,
        TOKdelegatefuncptr,

        // 54
        // Operators
        TOKlt, TOKgt,
        TOKle, TOKge,
        TOKequal, TOKnotequal,
        TOKidentity, TOKnotidentity,
        TOKindex, TOKis,

        // 64
        TOKshl, TOKshr,
        TOKshlass, TOKshrass,
        TOKushr, TOKushrass,
        TOKcat, TOKcatass, TOKcatelemass, TOKcatdcharass,     // ~ ~=
        TOKadd, TOKmin, TOKaddass, TOKminass,
        TOKmul, TOKdiv, TOKmod,
        TOKmulass, TOKdivass, TOKmodass,
        TOKand, TOKor, TOKxor,
        TOKandass, TOKorass, TOKxorass,
        TOKassign, TOKnot, TOKtilde,
        TOKplusplus, TOKminusminus, TOKconstruct, TOKblit,
        TOKdot, TOKcomma,
        TOKquestion, TOKandand, TOKoror,
        TOKpreplusplus, TOKpreminusminus,

        // 105
        // Numeric literals
        TOKint32v, TOKuns32v,
        TOKint64v, TOKuns64v,
        TOKint128v, TOKuns128v,
        TOKfloat32v, TOKfloat64v, TOKfloat80v,
        TOKimaginary32v, TOKimaginary64v, TOKimaginary80v,

        // Char constants
        TOKcharv, TOKwcharv, TOKdcharv,

        // Leaf operators
        TOKidentifier, TOKstring, TOKxstring,
        TOKthis, TOKsuper,
        TOKhalt, TOKtuple,
        TOKerror,

        // Basic types
        TOKvoid,
        TOKint8, TOKuns8,
        TOKint16, TOKuns16,
        TOKint32, TOKuns32,
        TOKint64, TOKuns64,
        TOKint128, TOKuns128,
        TOKfloat32, TOKfloat64, TOKfloat80,
        TOKimaginary32, TOKimaginary64, TOKimaginary80,
        TOKcomplex32, TOKcomplex64, TOKcomplex80,
        TOKchar, TOKwchar, TOKdchar, TOKbool,

        // 152
        // Aggregates
        TOKstruct, TOKclass, TOKinterface, TOKunion, TOKenum, TOKimport,
        TOKalias, TOKoverride, TOKdelegate, TOKfunction,
        TOKmixin,

        TOKalign, TOKextern, TOKprivate, TOKprotected, TOKpublic, TOKexport,
        TOKstatic, TOKfinal, TOKconst, TOKabstract,
        TOKdebug, TOKdeprecated, TOKin, TOKout, TOKinout, TOKlazy,
        TOKauto, TOKpackage, TOKimmutable,

        // 182
        // Statements
        TOKif, TOKelse, TOKwhile, TOKfor, TOKdo, TOKswitch,
        TOKcase, TOKdefault, TOKbreak, TOKcontinue, TOKwith,
        TOKsynchronized, TOKreturn, TOKgoto, TOKtry, TOKcatch, TOKfinally,
        TOKasm, TOKforeach, TOKforeach_reverse,
        TOKscope,
        TOKon_scope_exit, TOKon_scope_failure, TOKon_scope_success,

        // 206
        // Contracts
        TOKinvariant,

        // Testing
        TOKunittest,

        // Added after 1.0
        TOKargTypes,
        TOKref,
        TOKmacro,

        // 211
        TOKparameters,
        TOKtraits,
        TOKoverloadset,
        TOKpure,
        TOKnothrow,
        TOKgshared,
        TOKline,
        TOKfile,
        TOKfilefullpath,
        TOKmodulestring,
        TOKfuncstring,
        TOKprettyfunc,
        TOKshared,
        TOKat,
        TOKpow,
        TOKpowass,
        TOKgoesto,
        TOKvector,
        TOKpound,

        // 230
        TOKinterval,
        TOKvoidexp,
        TOKcantexp,
        TOKshowctfecontext,

        TOKobjc_class_reference,
        TOKvectorarray,

        TOKarrow,
        TOKcolonColon,
        TOKwchar_tLiteral,
        TOKcompoundLiteral,

        TOKinline,
        TOKregister,
        TOKrestrict,
        TOKsigned,
        TOKsizeof_,
        TOKtypedef_,
        TOKunsigned,
        TOKvolatile,
        TOK_Alignas,
        TOK_Alignof,
        TOK_Atomic,
        TOK_Bool,
        TOK_Complex,
        TOK_Generic,
        TOK_Imaginary,
        TOK_Noreturn,
        TOK_Static_assert,
        TOK_Thread_local,

        TOK__cdecl,
        TOK__declspec,
        TOK__attribute__,

        TOKMAX
        */
    }
}
