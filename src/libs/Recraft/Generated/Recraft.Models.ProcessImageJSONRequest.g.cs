#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProcessImageJSONRequest : global::System.IEquatable<ProcessImageJSONRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ProcessImageRequestBase? Base { get; init; }
#else
        public global::Recraft.ProcessImageRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.ProcessImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ProcessImageRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ProcessImageJSONRequestVariant2? ProcessImageJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.ProcessImageJSONRequestVariant2? ProcessImageJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProcessImageJSONRequestVariant2))]
#endif
        public bool IsProcessImageJSONRequestVariant2 => ProcessImageJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProcessImageJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.ProcessImageJSONRequestVariant2? value)
        {
            value = ProcessImageJSONRequestVariant2;
            return IsProcessImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ProcessImageJSONRequestVariant2 PickProcessImageJSONRequestVariant2() => IsProcessImageJSONRequestVariant2
            ? ProcessImageJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProcessImageJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProcessImageJSONRequest(global::Recraft.ProcessImageRequestBase value) => new ProcessImageJSONRequest((global::Recraft.ProcessImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ProcessImageRequestBase?(ProcessImageJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ProcessImageJSONRequest(global::Recraft.ProcessImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProcessImageJSONRequest FromBase(global::Recraft.ProcessImageRequestBase? value) => new ProcessImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProcessImageJSONRequest(global::Recraft.ProcessImageJSONRequestVariant2 value) => new ProcessImageJSONRequest((global::Recraft.ProcessImageJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ProcessImageJSONRequestVariant2?(ProcessImageJSONRequest @this) => @this.ProcessImageJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ProcessImageJSONRequest(global::Recraft.ProcessImageJSONRequestVariant2? value)
        {
            ProcessImageJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProcessImageJSONRequest FromProcessImageJSONRequestVariant2(global::Recraft.ProcessImageJSONRequestVariant2? value) => new ProcessImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ProcessImageJSONRequest(
            global::Recraft.ProcessImageRequestBase? @base,
            global::Recraft.ProcessImageJSONRequestVariant2? processImageJSONRequestVariant2
            )
        {
            Base = @base;
            ProcessImageJSONRequestVariant2 = processImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ProcessImageJSONRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ProcessImageJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsProcessImageJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.ProcessImageRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.ProcessImageJSONRequestVariant2, TResult>? processImageJSONRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsProcessImageJSONRequestVariant2 && processImageJSONRequestVariant2 != null)
            {
                return processImageJSONRequestVariant2(ProcessImageJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.ProcessImageRequestBase>? @base = null,

            global::System.Action<global::Recraft.ProcessImageJSONRequestVariant2>? processImageJSONRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsProcessImageJSONRequestVariant2)
            {
                processImageJSONRequestVariant2?.Invoke(ProcessImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.ProcessImageRequestBase>? @base = null,
            global::System.Action<global::Recraft.ProcessImageJSONRequestVariant2>? processImageJSONRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsProcessImageJSONRequestVariant2)
            {
                processImageJSONRequestVariant2?.Invoke(ProcessImageJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Recraft.ProcessImageRequestBase),
                ProcessImageJSONRequestVariant2,
                typeof(global::Recraft.ProcessImageJSONRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ProcessImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ProcessImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ProcessImageJSONRequestVariant2?>.Default.Equals(ProcessImageJSONRequestVariant2, other.ProcessImageJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProcessImageJSONRequest obj1, ProcessImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProcessImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProcessImageJSONRequest obj1, ProcessImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProcessImageJSONRequest o && Equals(o);
        }
    }
}
