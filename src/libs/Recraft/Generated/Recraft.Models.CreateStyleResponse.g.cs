#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateStyleResponse : global::System.IEquatable<CreateStyleResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.Style? Style { get; init; }
#else
        public global::Recraft.Style? Style { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Style))]
#endif
        public bool IsStyle => Style != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.CreateStyleResponseVariant2? CreateStyleResponseVariant2 { get; init; }
#else
        public global::Recraft.CreateStyleResponseVariant2? CreateStyleResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateStyleResponseVariant2))]
#endif
        public bool IsCreateStyleResponseVariant2 => CreateStyleResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStyleResponse(global::Recraft.Style value) => new CreateStyleResponse((global::Recraft.Style?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.Style?(CreateStyleResponse @this) => @this.Style;

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleResponse(global::Recraft.Style? value)
        {
            Style = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStyleResponse(global::Recraft.CreateStyleResponseVariant2 value) => new CreateStyleResponse((global::Recraft.CreateStyleResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.CreateStyleResponseVariant2?(CreateStyleResponse @this) => @this.CreateStyleResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleResponse(global::Recraft.CreateStyleResponseVariant2? value)
        {
            CreateStyleResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleResponse(
            global::Recraft.Style? style,
            global::Recraft.CreateStyleResponseVariant2? createStyleResponseVariant2
            )
        {
            Style = style;
            CreateStyleResponseVariant2 = createStyleResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateStyleResponseVariant2 as object ??
            Style as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Style?.ToString() ??
            CreateStyleResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStyle && IsCreateStyleResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.Style?, TResult>? style = null,
            global::System.Func<global::Recraft.CreateStyleResponseVariant2?, TResult>? createStyleResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStyle && style != null)
            {
                return style(Style!);
            }
            else if (IsCreateStyleResponseVariant2 && createStyleResponseVariant2 != null)
            {
                return createStyleResponseVariant2(CreateStyleResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.Style?>? style = null,
            global::System.Action<global::Recraft.CreateStyleResponseVariant2?>? createStyleResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStyle)
            {
                style?.Invoke(Style!);
            }
            else if (IsCreateStyleResponseVariant2)
            {
                createStyleResponseVariant2?.Invoke(CreateStyleResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Style,
                typeof(global::Recraft.Style),
                CreateStyleResponseVariant2,
                typeof(global::Recraft.CreateStyleResponseVariant2),
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
        public bool Equals(CreateStyleResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.Style?>.Default.Equals(Style, other.Style) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.CreateStyleResponseVariant2?>.Default.Equals(CreateStyleResponseVariant2, other.CreateStyleResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateStyleResponse obj1, CreateStyleResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateStyleResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateStyleResponse obj1, CreateStyleResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateStyleResponse o && Equals(o);
        }
    }
}
